using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_defaultmemberattribute_DefaultMemberAttributeMemberName_DefaultMemberAttributeMemberName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_defaultmemberattribute_DefaultMemberAttributeMemberName_DefaultMemberAttributeMemberName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\defaultmemberattribute\\DefaultMemberAttributeMemberName\\DefaultMemberAttributeMemberName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
