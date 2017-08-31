using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XModuletest1_xmod__XModuletest1_xmod_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XModuletest1_xmod__XModuletest1_xmod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XModuletest1-xmod\\_XModuletest1-xmod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
