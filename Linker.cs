using System;
using System.Collections.Generic;

namespace IMPLCLASS
{
    interface AbstractMeasure
    {
        int FigureArea();
    }

    
    abstract class Component
    {
        protected Random random = new Random();
        public abstract string Operation();

        public virtual void Add(Component cmp)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component cmp)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
        public virtual int FigureArea()
        {
            int m_randomValue = 0;
            return m_randomValue;
        }
    }
    class Group : Component
    {
        private int m_iSumAreas;

        public Group()
        {
            m_iSumAreas = 0;
        }
        
        protected List<Component> _children = new List<Component>();

        public override void Add(Component m_cmp)
        {
            this._children.Add(m_cmp);
        }

        public override void Remove(Component m_cmp)
        {
            this._children.Remove(m_cmp);
        }

        public override string Operation()
        {
            int m_i = 0;
            string m_result = "Group(";

            foreach (Component m_cmp in this._children)
            {
                m_result += m_cmp.Operation();
                if (m_i != this._children.Count - 1)
                {
                    m_result += "+";
                }
                m_i++;
            }

            return m_result + ")";
        }

        public void CalcMeasure()
        {

            foreach (Component m_cmp in this._children)
            {
                m_iSumAreas += m_cmp.FigureArea();
            }
        }

        public int GetSumAreas()
        {
            return m_iSumAreas;
        }

    }
    class Figure : Component, AbstractMeasure
    {
        public override int FigureArea()
        {
            int m_randomValue = random.Next(10, 100);
            return m_randomValue;
        }

        public override string Operation()
        {
            return "Figure";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
    class Client
    {
        public void ClientCode(Component m_cmp)
        {
            Console.WriteLine($"RESULT: {m_cmp.Operation()}\n");
        }

        public void ClientCode2(Component m_cmp1, Component m_cmp2)
        {
            if (m_cmp1.IsComposite())
            {
                m_cmp1.Add(m_cmp2);
            }

            Console.WriteLine($"RESULT: {m_cmp1.Operation()}");
        }
    }
}
