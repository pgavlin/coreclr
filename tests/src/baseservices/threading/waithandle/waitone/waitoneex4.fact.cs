using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitone_waitoneex4_waitoneex4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex4_waitoneex4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex4\\waitoneex4.cmd");
        }
    }
}
