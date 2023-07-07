using System;
using System.Collections.Generic;

namespace StateMachinePattern_After
{
    public class StateMachine
    {
        private static readonly List<Transition> EmptyTransitions = new List<Transition>(0);

        private IState _currentState;
        private readonly Dictionary<Type, List<Transition>> _transitions;
        private List<Transition> _currentTransitions;

        public StateMachine()
        {
            _transitions  = new Dictionary<Type, List<Transition>>();
            _currentTransitions = new List<Transition>();
        }

        public void Tick()
        {
            var transition = GetTransition();
            if (transition != null)
                SetState(transition.To, transition.SelfTransition);

            _currentState?.Tick();
        }

        public void SetState(IState state, bool forced = false)
        {
            if (state == _currentState && !forced)
                return;
            _currentState?.OnExit();
            _currentState = state;
            Type type = _currentState.GetType();
            _transitions.TryGetValue(type, out _currentTransitions);
            if (_currentTransitions == null)
                _currentTransitions = EmptyTransitions;
            _currentState.OnEnter();
        }

        public void AddTransition(IState from, IState to, Func<bool> predicate)
        {
            if (_transitions.TryGetValue(from.GetType(), out var transitions) == false)
            {
                transitions = new List<Transition>();
                _transitions[from.GetType()] = transitions;
            }

            transitions.Add(new Transition(to, predicate, from.Equals(to)));
        }

        private class Transition
        {
            public Func<bool> Condition { get; }
            public bool SelfTransition { get; }
            public IState To { get; }

            public Transition(IState to, Func<bool> condition, bool selfTransition = false)
            {
                To = to;
                Condition = condition;
                SelfTransition = selfTransition;
            }
        }

        private Transition GetTransition()
        {
            foreach (var transition in _currentTransitions)
                if (transition.Condition())
                    return transition;
            return null;
        }
    }
}