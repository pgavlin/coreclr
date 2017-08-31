using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _gettypetypeof_gettypetypeofmatrix_gettypetypeofmatrix_
    {
        [Fact]
        public void _gettypetypeof_gettypetypeofmatrix_gettypetypeofmatrix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\gettypetypeof\\gettypetypeofmatrix\\gettypetypeofmatrix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
