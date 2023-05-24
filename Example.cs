//GC는 C#에서 자동으로 관리되는 메모리 할당 및 해제를 담당한다.
//그러나 잘못된 코드 작성 시에는 GC가 완벽하게 모든 메모리 누수를 처리하지는 않는다.

//GC를 사용하더라도 메모리 누수가 발생할 수 있는 코드
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>();
        
        while (true)
        {
            string input = Console.ReadLine();
            
            if (input == "exit")
                break;
                
            stringList.Add(input);
            
            Console.WriteLine("Added: " + input);
        }
        
        // stringList를 사용한 후에 할당을 해제하지 않음
    }
}

//사용자로부터 입력을 받아서 'stringList'라는 'List<string>'에 저장
//'stringList'를 사용한 후에 할당을 해제하지 않고 루프를 무한히 반복중
//이 경우에 계속해서 'stringList'가 커지며 메모리에 계속 남게됨

//메모리 leak을 방지하기 위한 해결법
<b>stringList = null;</b>   //'stringList'에 'null'을 할당하여 해제할 수 있다.
//GC는 더이상 'stringList'가 사용되지 않는 것을 인지하고 해당 메모리를 해제할 수 있다.

#reference(참조) : chat-GPT
