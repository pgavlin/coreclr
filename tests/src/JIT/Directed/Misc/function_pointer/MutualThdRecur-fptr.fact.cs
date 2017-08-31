using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_
    {
        [Fact]
        public void _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\function_pointer\\MutualThdRecur-fptr\\MutualThdRecur-fptr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
