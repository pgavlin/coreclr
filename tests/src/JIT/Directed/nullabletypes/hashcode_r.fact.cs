using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hashcode_r_hashcode_r_
    {
        [Fact]
        public void _nullabletypes_hashcode_r_hashcode_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hashcode_r\\hashcode_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
