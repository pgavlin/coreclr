using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCSuppressFinalize_GCSuppressFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCSuppressFinalize_GCSuppressFinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCSuppressFinalize\\GCSuppressFinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
