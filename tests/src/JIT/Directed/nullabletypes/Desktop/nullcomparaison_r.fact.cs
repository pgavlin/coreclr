using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_nullcomparaison_r_nullcomparaison_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_Desktop_nullcomparaison_r_nullcomparaison_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\nullcomparaison_r\\nullcomparaison_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
