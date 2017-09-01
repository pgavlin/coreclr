using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitone_waitoneex2_waitoneex2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex2_waitoneex2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex2\\waitoneex2.cmd");
        }
    }
}
