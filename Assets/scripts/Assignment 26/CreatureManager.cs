using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A Creature make a sound  ");
        }
    }

    public interface IRunnable
    {
        public void Run();
    }
    public interface IJumpable
    {
        public void Jump();
    }
    public interface ISwimmable
    {
        public void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps");
        }
        public override void Speak()
        {
            Debug.Log("Kangroo says: Hop!");
        }
    }
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }

    public class CreatureManager : MonoBehaviour
    {
        List<IRunnable> runnables;
        List<IJumpable> jumpables;
        List<ISwimmable> swimmales;
        List<Creature> creatures;
        void Start()
        {
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            creatures = new List<Creature> { kangaroo, duck };
            runnables = new List<IRunnable>() { kangaroo, duck };
            jumpables = new List<IJumpable>() { kangaroo };
            swimmales = new List<ISwimmable>() { duck };

            //runnables.Add(kangaroo);
            //jumpables.Add(kangaroo);

            //runnables.Add(duck);
            //swimmales.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmales)
            {
                swimmable.Swim();
            }
        }
    }
}