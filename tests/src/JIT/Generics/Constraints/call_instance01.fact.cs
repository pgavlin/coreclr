using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_call_instance01_call_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_call_instance01_call_instance01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\call_instance01\\call_instance01.cmd");
        }
    }
}
