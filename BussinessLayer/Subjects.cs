using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public interface IID<TKey>
    {
         TKey ID { get; set; }
    }
    public class MyGenericClass<TKey,TVal> : IDisposable where TVal :IID<TKey>
    {
        private Dictionary<TKey, TVal> items;

        public MyGenericClass()
        {
            items = new Dictionary<TKey, TVal>();
        }

        public void Add(TVal item)
        {
            if (items.ContainsKey(item.ID))
            {

            }
            else
                items.Add(item.ID, item);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    [Serializable]
    public class Subjects : IDisposable
    {
        private Dictionary<int, Subject> subjects;

        public Subjects()
        {
            subjects = new Dictionary<int, Subject>();
        }

        public void Add(Subject subject)
        {
            if(subjects.ContainsKey(subject.ID))
            {
                throw new DuplicateKeyException("Subject already present");
            }
            else
            {
                subjects.Add(subject.ID, subject);
            }
        }

        public Subject Find(int id)
        {
            return subjects[id];
        }

        public void Remove(int id)
        {
            subjects.Remove(id);
        }

        public IEnumerable<Subject> GetAllSubjets()
        {
            return subjects.Values;
        }
        public void Dispose()
        {
            subjects = null;
        }
    }
}
