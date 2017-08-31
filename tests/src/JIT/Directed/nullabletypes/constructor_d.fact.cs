using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_constructor_d_constructor_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_d_constructor_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_d\\constructor_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
