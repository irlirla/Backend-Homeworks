using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork2
{
    public interface IListRepository
    {
        public List<Users> ListGet();
        public void ListDelete(int id);
        public void ListPut(int id, Users info);
        public void ListPost(Users info);

    }

    public interface IFileRepository
    {
        public string GetText();
        public string AddText(string str);

        public string DeleteText();

        public string PutText(string str);
    }


}
