using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_constructor_r_constructor_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_r_constructor_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_r\\constructor_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
