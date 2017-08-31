using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_Desktop_nullcomparaison_ro_nullcomparaison_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_Desktop_nullcomparaison_ro_nullcomparaison_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\Desktop\\nullcomparaison_ro\\nullcomparaison_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
