using System;

namespace code_trainning
{
	class Program
	{
		static void Main( string[] args )
		{
            // 입력된 정수를 반대로 배열에 집어넣기
            int[] answer = Solution_01( 12345 );
            string result = string.Empty;
            for ( int i = 0; i < answer.Length; ++i )
            {
                result += answer[i];
            }
            Console.WriteLine( "Solution = " + result );

            // 입력된 두 수의, 최대공약수 구하기
            answer = Solution_02( 60, 48 );
            Console.WriteLine( "Gratest Common Factor = " + answer[0] );
            Console.WriteLine( "Least Common Multiple = " + answer[1] );
        }

        // 입력된 정수를 반대로 배열에 집어넣기
        public static int[] Solution_01( long n )
        {
            int[] answer = new int[n.ToString().Length];

            long divideValue = 10;
            int i = 0;

            while ( true )
            {
                answer[i] = (int)( n % divideValue );
                n /= divideValue;
                i += 1;

                if ( n < 1 )
                    break;
            }

            return answer;
        }

        // 입력된 두 수의, 최대공약수 최소공배수 구하기
        // 어떤 수를 나누어떨어지게 하는 수를 그 수의 약수라고 합니다.
        // 어떤 수를 1배, 2배, 3배....... 한 수를 그 수의 배수라고 합니다
        public static int[] Solution_02( int n, int m )
        {
            int max_divide = 1;
            int range = Math.Min( n, m );
            int n_divide = 0;
            int m_divide = 0;

            for ( int i = 1; i < range; ++i )
            {
                if ( n % i == 0 && m % i == 0 )
                {
                    max_divide = i;
                    n_divide = n / i;
                    m_divide = m / i;
                }
            }

            int[] answer = new int[2];
            answer[0] = max_divide;
            answer[1] = max_divide * n_divide * m_divide;

            return answer;
        }

    }
}
