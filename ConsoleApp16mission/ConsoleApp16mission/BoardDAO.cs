using System;
using System.Collections;

namespace Board
{
    class BoardDAO
    {
        public int Insert(BoardVO vo)
        {
            Console.WriteLine("Insert(BoardVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public int Update(BoardVO vo)
        {
            Console.WriteLine("Update(BoardVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public int Delete(BoardVO vo)
        {
            Console.WriteLine("Delete(BoardVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public BoardVO SelectOne(BoardVO vo)
        {
            Console.WriteLine("SelectOne(BoardVO vo)");
            BoardVO vo2 = vo;
            return vo2;
        }

        public ArrayList SelectAll()
        {
            Console.WriteLine("SelectAll()");

            ArrayList list = new ArrayList();
            for (int i = 0; i < 7; i++)
            {
                BoardVO vo = new BoardVO();
                vo.Num = i;
                vo.Title = "Title" + i;
                vo.Content = "Content Content Content";
                vo.Writer = "Kim" + i;
                vo.Wdate = DateTime.Now;
                list.Add(vo);
            }
            return list;
        }

        public ArrayList SearchList(string searchKey, string searchWord)
        {
            Console.WriteLine("SearchList(string searchKey, string searchWord)");
            Console.WriteLine("search key = {0}", searchKey);
            Console.WriteLine("search word = {0}", searchWord);

            ArrayList list = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                BoardVO vo = new BoardVO();
                vo.Num = i;
                vo.Title = "Title" + i;
                vo.Content = "Content Content Content";
                vo.Writer = "Kim" + i;
                vo.Wdate = DateTime.Now;
                list.Add(vo);
            }
            return list;
        }
    }
}
