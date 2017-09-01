using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Misc_function_pointer_funcptrtest_funcptrtest_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_function_pointer_funcptrtest_funcptrtest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\function_pointer\\funcptrtest\\funcptrtest.cmd");
        }
    }
}
