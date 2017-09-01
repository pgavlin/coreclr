using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanyex5_waitanyex5_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex5_waitanyex5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex5\\waitanyex5.cmd");
        }
    }
}
