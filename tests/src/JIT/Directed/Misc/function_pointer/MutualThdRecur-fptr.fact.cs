using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_
    {
        [Fact]
        public void _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\function_pointer\\MutualThdRecur-fptr\\MutualThdRecur-fptr.cmd");
        }
    }
}
