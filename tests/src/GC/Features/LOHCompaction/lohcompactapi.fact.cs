using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohcompactapi_lohcompactapi_
    {
        [Fact]
        public void _LOHCompaction_lohcompactapi_lohcompactapi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactapi\\lohcompactapi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
