using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCSuppressFinalize_GCSuppressFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCSuppressFinalize_GCSuppressFinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCSuppressFinalize\\GCSuppressFinalize.cmd");
        }
    }
}
