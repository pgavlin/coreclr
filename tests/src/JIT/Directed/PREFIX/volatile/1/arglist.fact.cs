using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_volatile_1_arglist_arglist_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_arglist_arglist_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\arglist\\arglist.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
