using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _LOHCompaction_lohcompactapi_lohcompactapi_
    {
        [Fact]
        public void _LOHCompaction_lohcompactapi_lohcompactapi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactapi\\lohcompactapi.cmd");
        }
    }
}
