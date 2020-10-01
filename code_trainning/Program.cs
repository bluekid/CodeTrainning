using System;

namespace UnitTest
{
    class MainClass
    {
        public static void Main( string[] args )
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 입력된 정수를 반대로 배열에 집어넣기
            CodeTestLevel01.Solution_01( 12345 );

            CodeTestLevel01.Solution_02( 60, 48 );

            CodeTestLevel01.solution_03( 3 );

            CodeTestLevel01.solution_04( "0109475628" );
        }
    }
}
