using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanyex2_waitanyex2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex2_waitanyex2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex2\\waitanyex2.cmd");
        }
    }
}
