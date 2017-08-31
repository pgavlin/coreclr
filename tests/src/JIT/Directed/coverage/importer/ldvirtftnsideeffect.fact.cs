using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_ldvirtftnsideeffect_ldvirtftnsideeffect_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_ldvirtftnsideeffect_ldvirtftnsideeffect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\ldvirtftnsideeffect\\ldvirtftnsideeffect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
