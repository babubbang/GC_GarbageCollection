# GC_GarbageCollection

2. 가비지 컬렉션 (Garbage Collection)
- GC 에 대해 조사하고, 본인의 깃허브에 public 프로젝트로 등록하여 정리하시오.

- 왜 필요하고, 어떤 매커니즘으로 동작되는지 (본인이 확실히 이해한 내용을 기술)

- GC 가 제대로 동작되도록 코드를 어떻게 작성해야 하는지, 어떻게 하면 GC 로도 메모리 leak 이 발생되는지 예제 코드와 함께 설명

- 언어는 Python, Java, JavaScript, C# 중 택1

<h2>1️⃣ Garbage Collection이란? </h2><br>
<b>가비지 컬렉션(Garbage Collection)</b>은 프로그래밍 언어에서 동적으로 할당된 메모리 영역 중에서 더 이상 사용되지 않는 객체들을 자동으로 찾아내고, 해당 객체들이 차지하고 있는 메모리를 해제하는 프로세스를 말한다.<br>
<b>C#에서의 가비지 컬렉션</b><br>
C#으로 작성한 코드는 .NET Framework 위에서 실행되며 CLR(공용 언어 런타임)에서 가비지 컬렉션(GC)은 애플리케이션의 메모리 할당 및 해제를 관리하는 역할을 한다.<br>

<h2>2️⃣ Garbage Collection이 필요한 이유 </h2><br>
Garbage Collection을 사용하면 다음과 같은 이점을 얻을 수 있다.<br>
 - 개발자가 수동으로 메모리를 해제할 필요가 없다.<br>
 - 관리되는 힙에 효율적으로 개체를 할당한다.<br>
 - 더 이상 사용되지 않는 개체를 회수하고 이러한 개체의 메모리를 비워 이후 할당에서 이 메모리를 사용할 수 있도록 한다. 관리되는 개체는 자동으로 시작을 위한 정리된 콘텐츠를 받으므로 개체의 생성자가 모든 데이터 필드를 초기화할 필요가 없다.<br>
 - 개체가 다른 개체에 할당된 메모리 자체에 사용할 수 없도록 하여 메모리 보안을 제공한다.<br>