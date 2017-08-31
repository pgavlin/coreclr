using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_gettype_gettypetypeofmatrix_gettypetypeofmatrix_
    {
        [Fact]
        public void _Misc_gettype_gettypetypeofmatrix_gettypetypeofmatrix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\gettype\\gettypetypeofmatrix\\gettypetypeofmatrix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
