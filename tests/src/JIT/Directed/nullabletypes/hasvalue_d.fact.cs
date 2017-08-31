using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hasvalue_d_hasvalue_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_d_hasvalue_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_d\\hasvalue_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
