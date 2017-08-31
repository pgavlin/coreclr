using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hashcode_do_hashcode_do_
    {
        [Fact]
        public void _nullabletypes_hashcode_do_hashcode_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hashcode_do\\hashcode_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
