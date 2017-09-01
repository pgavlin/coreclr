using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanyex3_waitanyex3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex3_waitanyex3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex3\\waitanyex3.cmd");
        }
    }
}
