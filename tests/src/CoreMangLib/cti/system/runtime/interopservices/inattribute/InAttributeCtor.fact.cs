using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_inattribute_InAttributeCtor_InAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_inattribute_InAttributeCtor_InAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\inattribute\\InAttributeCtor\\InAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
