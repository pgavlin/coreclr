using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanyex8a_waitanyex8a_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex8a_waitanyex8a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex8a\\waitanyex8a.cmd");
        }
    }
}
