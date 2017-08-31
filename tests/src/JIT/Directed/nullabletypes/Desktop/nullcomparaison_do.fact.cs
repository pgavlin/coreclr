using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_nullcomparaison_do_nullcomparaison_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_Desktop_nullcomparaison_do_nullcomparaison_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\nullcomparaison_do\\nullcomparaison_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
