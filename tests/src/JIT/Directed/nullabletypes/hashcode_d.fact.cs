using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hashcode_d_hashcode_d_
    {
        [Fact]
        public void _nullabletypes_hashcode_d_hashcode_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hashcode_d\\hashcode_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
