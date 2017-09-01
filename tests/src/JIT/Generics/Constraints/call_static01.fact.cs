using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Constraints_call_static01_call_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Constraints_call_static01_call_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Constraints\\call_static01\\call_static01.cmd");
        }
    }
}
