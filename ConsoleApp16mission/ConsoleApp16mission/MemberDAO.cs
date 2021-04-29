using System;
using System.Collections;
using Member;

namespace Member
{
    public class MemberDAO
    {
        public int Insert(MemberVO vo)
        {
            Console.WriteLine("Insert(MemberVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public int Update(MemberVO vo)
        {
            Console.WriteLine("Update(MemberVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public int Delete(MemberVO vo)
        {
            Console.WriteLine("Delete(MemberVO vo)");
            int res = 0;
            res = 1;
            return res;
        }

        public MemberVO SelectOne(MemberVO vo)
        {
            Console.WriteLine("SelectOne(MemberVO vo)");
            MemberVO vo2 = vo;
            return vo2;
        }

        public ArrayList SelectAll()
        {
            Console.WriteLine("SelectAll()");

            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                MemberVO vo = new MemberVO();
                vo.Num = i;
                vo.Id = "user" + i;
                vo.Pw = i * 100 + "";
                vo.Name = "Kim" + i;
                vo.Tel = "010-1234-1234";
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
                MemberVO vo = new MemberVO();
                vo.Num = i + 100;
                vo.Id = searchWord + i;
                vo.Pw = i * 100 + "";
                vo.Name = "Kim" + i;
                vo.Tel = "010-1234-1234";
                list.Add(vo);
            }
            return list;
        }

    }
}
