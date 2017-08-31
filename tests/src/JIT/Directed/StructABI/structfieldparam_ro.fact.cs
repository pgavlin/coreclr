using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructABI_structfieldparam_ro_structfieldparam_ro_
    {
        [OuterLoop]
        [Fact]
        public void _StructABI_structfieldparam_ro_structfieldparam_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\structfieldparam_ro\\structfieldparam_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
