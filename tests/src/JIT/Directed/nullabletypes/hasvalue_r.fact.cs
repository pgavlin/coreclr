using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hasvalue_r_hasvalue_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_r_hasvalue_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_r\\hasvalue_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
