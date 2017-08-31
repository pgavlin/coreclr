using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_function_pointer_funcptrtest_funcptrtest_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_function_pointer_funcptrtest_funcptrtest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\function_pointer\\funcptrtest\\funcptrtest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
