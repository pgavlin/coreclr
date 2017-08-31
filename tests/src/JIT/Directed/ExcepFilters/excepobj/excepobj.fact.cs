using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _ExcepFilters_excepobj_excepobj_excepobj_
    {
        [Fact]
        public void _ExcepFilters_excepobj_excepobj_excepobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\ExcepFilters\\excepobj\\excepobj\\excepobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
