using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_outattribute_OutAttributeCtor_OutAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_outattribute_OutAttributeCtor_OutAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\outattribute\\OutAttributeCtor\\OutAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
