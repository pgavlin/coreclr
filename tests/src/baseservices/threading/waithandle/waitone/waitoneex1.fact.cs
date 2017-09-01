using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitone_waitoneex1_waitoneex1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex1_waitoneex1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex1\\waitoneex1.cmd");
        }
    }
}
