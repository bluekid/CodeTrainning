using System;

namespace CodeTraining
{
    public class CodeTestLevel01
    {
        // 입력된 정수를 반대로 배열에 집어넣기
        public static int[] Solution01( long n )
        {
            int[] answer = new int[n.ToString().Length];

            long divideValue = 10;
            int arr = 0;

            while ( true )
            {
                answer[arr] = (int)( n % divideValue );
                n /= divideValue;
                arr += 1;

                if ( n < 1 )
                    break;
            }

            Console.WriteLine( "입력된 정수를 반대로 뒤집기" );
            Console.WriteLine( "입력된 정수 = " + n );
            Console.WriteLine( "결과 값 = " + answer );

            return answer;
        }

        /*************************************************************************************
         
            입력된 두 수의, 최대공약수 구하기
            어떤 수를 나누어떨어지게 하는 수를 그 수의 약수라고 합니다.
            어떤 수를 1배, 2배, 3배....... 한 수를 그 수의 배수라고 합니다
            
        *************************************************************************************/
        public static int[] Solution02( int n, int m )
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

            Console.WriteLine( "최대공약수(Gratest Common Factor) = " + answer[0] );
            Console.WriteLine( "최소공배수(Least Common Multiple) = " + answer[1] );

            return answer;
        }

        /*************************************************************************************
         
            길이가 n이고, 수박수박수박수....와 같은 패턴을 유지하는 문자열을 리턴하는 함수, solution을 완성하세요.
            예를들어 n이 4이면 수박수박을 리턴하고 3이라면 수박수를 리턴하면 됩니다
        
        *************************************************************************************/
        public static string Solution03( int length )
        {
            string[] soobak = { "수", "박" };
            string answer = "";

            for ( int i = 0; i < length; ++i )
            {
                answer += soobak[i % 2];
            }

            Console.WriteLine( "Solution_03 = " + answer );

            return answer;
        }

        /*************************************************************************************
         
            프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
            전화번호가 문자열 phone_number로 주어졌을 때, 
            전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을 리턴하는 함수, solution을 완성해주세요.
            
            제한 조건
                s는 길이 4 이상, 20이하인 문자열입니다.

            입출력 예
                phone_number	return
                01033334444	*******4444
                027778888

        *************************************************************************************/
        public static string Solution04( string phone_number )
        {
            string answer = "";

            for ( int i = 0; i < phone_number.Length; ++i )
            {
                if ( i < phone_number.Length - 4 )
                    answer += "*";
                else
                    answer += phone_number[i];
            }

            Console.WriteLine( "answer = " + answer );

            return answer;
        }
    }
}