using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohcompactapi_exceptions_lohcompactapi_exceptions_
    {
        [Fact]
        public void _LOHCompaction_lohcompactapi_exceptions_lohcompactapi_exceptions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactapi_exceptions\\lohcompactapi_exceptions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
