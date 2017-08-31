using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructABI_structfieldparam_r_structfieldparam_r_
    {
        [OuterLoop]
        [Fact]
        public void _StructABI_structfieldparam_r_structfieldparam_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\structfieldparam_r\\structfieldparam_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
