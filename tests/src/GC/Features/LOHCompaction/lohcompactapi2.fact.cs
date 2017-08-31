using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohcompactapi2_lohcompactapi2_
    {
        [OuterLoop]
        [Fact]
        public void _LOHCompaction_lohcompactapi2_lohcompactapi2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactapi2\\lohcompactapi2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
