using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_gc_GCReRegisterForFinalize_GCReRegisterForFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _system_gc_GCReRegisterForFinalize_GCReRegisterForFinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\gc\\GCReRegisterForFinalize\\GCReRegisterForFinalize.cmd");
        }
    }
}
