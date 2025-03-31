using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Myapp
{
    // 예시용 클래스 1
    class Goblin
    {
        public override string ToString() => "Goblin 객체";
    }

    // 예시용 클래스 2
    class Slime
    {
        public override string ToString() => "Slime 객체";
    }

    class MyClass
    {
        public void Run()
        {
            ArrayListExample();
            QueueExample();
            StackExample();
            HashtableExample();
        }

        private void ArrayListExample()
        {
            Console.WriteLine("== ArrayList Example ==");

            // ArrayList 선언 및 생성 (컬렉션 자료구조는 new로 메모리 할당 필요)
            ArrayList arrayList = new ArrayList();

            // 요소 추가 (순차적으로 추가)
            arrayList.Add(10);
            PrintArrayList(arrayList);

            // 원하는 위치에 요소 추가
            arrayList.Insert(1, 100);
            PrintArrayList(arrayList);

            // 다른 컬렉션의 요소들을 한 번에 추가
            Collection<int> data1 = new Collection<int> { 1, 2, 3 };
            arrayList.AddRange(data1);

            // 정렬 (모든 요소가 정수일 경우에만 가능)
            arrayList.Sort();
            PrintArrayList(arrayList);

            // 특정 값 삭제
            arrayList.Remove(10);
            PrintArrayList(arrayList);

            // 인덱스 위치로 삭제
            arrayList.RemoveAt(0);
            PrintArrayList(arrayList);

            // 범위 삭제 (0번부터 2개 삭제, 남은 개수보다 많으면 오류 방지)
            arrayList.RemoveRange(0, Math.Min(2, arrayList.Count));
            PrintArrayList(arrayList);

            // 모든 요소 삭제
            arrayList.Clear();
            Console.WriteLine($"ArrayList Count after Clear: {arrayList.Count}\n");
        }

        private void QueueExample()
        {
            Console.WriteLine("== Queue Example ==");

            // Queue 생성
            Queue queue = new Queue();

            // 후단에 요소 추가
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            // 현재 큐 요소 개수
            Console.WriteLine($"Queue Count: {queue.Count}");

            // 전단 요소 확인 (삭제 X)
            Console.WriteLine($"현재 0번 요소 : {queue.Peek()}");
            Console.WriteLine($"Queue Count (peek 후): {queue.Count}");

            // 전단 요소 삭제 + 반환
            object data = queue.Dequeue();
            Console.WriteLine($"큐에서 빠져나온 데이터 : {data}");
            Console.WriteLine($"Queue Count (dequeue 후): {queue.Count}");

            // 전체 요소 삭제
            queue.Clear();
            Console.WriteLine($"Queue Count (clear 후): {queue.Count}\n");
        }

        private void StackExample()
        {
            Console.WriteLine("== Stack Example ==");

            // Stack 생성
            Stack stack = new Stack();

            // 최상단에 요소 추가
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            // 스택 요소 개수 출력
            Console.WriteLine($"Stack Count: {stack.Count}");

            // 최상단 요소 확인 (삭제 X)
            Console.WriteLine($"마지막에 추가된 요소 : {stack.Peek()}");
            Console.WriteLine($"Stack Count (peek 후): {stack.Count}");

            // 최상단 요소 삭제 + 반환
            object data = stack.Pop();
            Console.WriteLine($"스택에서 빠져나온 데이터 : {data}");
            Console.WriteLine($"Stack Count (pop 후): {stack.Count}");

            // 전체 요소 삭제
            stack.Clear();
            Console.WriteLine($"Stack Count (clear 후): {stack.Count}\n");
        }

        private void HashtableExample()
        {
            Console.WriteLine("== Hashtable Example ==");

            // Hashtable 생성
            Hashtable hash = new Hashtable();

            // object 타입이기 때문에 클래스 인스턴스도 저장 가능
            Goblin goblin = new Goblin();
            Slime slime = new Slime();

            // 요소 추가 방법 1: 인덱서
            hash["Goblin"] = goblin;

            // 요소 추가 방법 2: Add 메서드
            hash.Add("Slime", slime);
            hash.Add(1, "용사");
            hash.Add(1.1f, "스킬");
            hash.Add("문자열", "안녕하세요. 고생하셨습니다.");

            // 모든 키와 값 출력
            foreach (object key in hash.Keys)
            {
                Console.WriteLine($"hash[{key}] = {hash[key]}");
            }

            // 키 존재 여부 확인
            if (hash.ContainsKey("Slime"))
            {
                Console.WriteLine("Slime 키 존재");
            }

            // 값 존재 여부 확인
            if (hash.ContainsValue(goblin))
            {
                Console.WriteLine("Goblin 값 존재");
            }

            // 요소 개수 확인
            Console.WriteLine($"Hashtable Count: {hash.Count}");

            // 특정 키 요소 삭제
            hash.Remove("Slime");
            Console.WriteLine($"Hashtable Count after Remove: {hash.Count}");

            // 모든 요소 삭제
            hash.Clear();
            Console.WriteLine($"Hashtable Count after Clear: {hash.Count}\n");
        }

        // ArrayList 출력용 유틸 함수
        private void PrintArrayList(ArrayList list)
        {
            Console.Write("ArrayList: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Run();
        }
    }
}
