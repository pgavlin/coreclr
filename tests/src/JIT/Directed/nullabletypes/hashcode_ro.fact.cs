using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hashcode_ro_hashcode_ro_
    {
        [Fact]
        public void _nullabletypes_hashcode_ro_hashcode_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hashcode_ro\\hashcode_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
