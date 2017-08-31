using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_catchretnonlocalexitinfunclet_ro_catchretnonlocalexitinfunclet_ro_
    {
        [Fact]
        public void _eh_leaves_catchretnonlocalexitinfunclet_ro_catchretnonlocalexitinfunclet_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\catchretnonlocalexitinfunclet_ro\\catchretnonlocalexitinfunclet_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
