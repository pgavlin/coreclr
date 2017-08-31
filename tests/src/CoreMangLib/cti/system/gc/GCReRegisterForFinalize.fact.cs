using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_gc_GCReRegisterForFinalize_GCReRegisterForFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCReRegisterForFinalize_GCReRegisterForFinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCReRegisterForFinalize\\GCReRegisterForFinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
