using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_catchretnonlocalexitinfunclet_d_catchretnonlocalexitinfunclet_d_
    {
        [Fact]
        public void _eh_leaves_catchretnonlocalexitinfunclet_d_catchretnonlocalexitinfunclet_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\catchretnonlocalexitinfunclet_d\\catchretnonlocalexitinfunclet_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
