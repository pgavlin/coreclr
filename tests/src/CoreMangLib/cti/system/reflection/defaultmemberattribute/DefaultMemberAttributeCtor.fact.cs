using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_defaultmemberattribute_DefaultMemberAttributeCtor_DefaultMemberAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_defaultmemberattribute_DefaultMemberAttributeCtor_DefaultMemberAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\defaultmemberattribute\\DefaultMemberAttributeCtor\\DefaultMemberAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
