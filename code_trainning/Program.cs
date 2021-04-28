/*
 * 
 *      Code Training Project
 * 
 */
using System;
using DataStructTraining;

namespace UnitTest
{
    class MainClass
    {
        public static void Main( string[] args )
        {
            MainClass main = new MainClass();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //main.CodeTestLevel01();

            main.DataStructTraining();
        }

        public void CodeTestLevel01()
        {
            // 입력된 정수를 반대로 배열에 집어넣기
            CodeTraining.CodeTestLevel01.Solution01( 12345 );

            // 입력된 두 수의, 최대공약수 구하기
            CodeTraining.CodeTestLevel01.Solution02( 60, 48 );

            // 길이가 n이고, 수박수박수박수....와 같은 패턴을 유지하는 문자열을 리턴하는 함수
            CodeTraining.CodeTestLevel01.Solution03( 3 );

            CodeTraining.CodeTestLevel01.Solution04( "0109475628" );
        }

        public void DataStructTraining()
        {
            LinkedList linkedlist = new LinkedList();

            for ( int i = 0; i < 5; ++i )
            {
                linkedlist.Add( i );
            }

            linkedlist.PrinitAllData();

            linkedlist.Remove( 4 );

            linkedlist.PrinitAllData();
        }
    }
}
