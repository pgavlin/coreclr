using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XModuletest4_xmod__XModuletest4_xmod_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XModuletest4_xmod__XModuletest4_xmod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XModuletest4-xmod\\_XModuletest4-xmod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
